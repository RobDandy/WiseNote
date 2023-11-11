namespace WiseNote.Domain;
/// <summary>
/// Defines a property for a node or a relationship in a graph database. 
/// Properties are key-value pairs used to store additional data dynamically. 
/// </summary>
/// <param name="Name">The key or name of the property. It uniquely identifies the property within a node or a relationship.</param>
/// <param name="DataType">Specifies the type of data this property holds (e.g., string, int, date). This is used parse property's value</param>
/// <param name="Value">The actual data or value of the property, stored as a string.</param>
public record Property(string Name, string DataType, string Value);
