namespace WiseNote.Domain;

/// <summary>
/// Represents a relationship between two nodes in a graph database.
/// </summary>
/// <param name="Label">A label describing the type or nature of the relationship.</param>
/// <param name="SourceNode">The source node from which the relationship originates.</param>
/// <param name="TargetNode">The target node to which the relationship points.</param>
/// <param name="Properties">A list of properties associated with the relationship.</param>
public record Relation(string Label, Node SourceNode, Node TargetNode, IList<Property> Properties);

