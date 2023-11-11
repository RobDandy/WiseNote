namespace WiseNote.Domain;

/// <summary>
/// Represents a generic node in a graph database.
/// </summary>
/// <param name="Id">A unique identifier for the node.</param>
/// <param name="Label">A descriptive label for the node, indicating its type or role.</param>
/// <param name="Properties">A list of properties associated with the node.</param>
public record Node(Guid Id, string Label, IList<Property> Properties);

