using System.Collections.Generic;
using NSubstitute;
using Xunit;

public class CopierTests
{
    [Fact]
    public void Copy_ReadsCharactersFromSourceAndWritesToDestination_UntilNewlineEncountered()
    {
        // Arrange
        var sourceMock = Substitute.For<ISource>();
        var destinationMock = Substitute.For<IDestination>();

        var characters = new Queue<char>(new[] { 'H', 'e', 'l', 'l', 'o', '\n' });

        // Mock the ReadChar method to return characters from the queue
        sourceMock.ReadChar().Returns(_ => characters.Dequeue());

        var copier = new Copier(sourceMock, destinationMock);

        // Act
        copier.Copy();

        // Assert
        Received.InOrder(() =>
        {
            destinationMock.WriteChar('H');
            destinationMock.WriteChar('e');
            destinationMock.WriteChar('l');
            destinationMock.WriteChar('l');
            destinationMock.WriteChar('o');
        });

        // Verify that no newline was written
        destinationMock.DidNotReceive().WriteChar('\n');
    }
}
