namespace CommonLib.IrcParser.Tags;

/// <inheritdoc cref="IMessageTag"/>
public record MessageTag(string Name) : IMessageTag
{
    /// <inheritdoc cref="IMessageTag.Value"/>
    public virtual string? Value { get; set; }
}
