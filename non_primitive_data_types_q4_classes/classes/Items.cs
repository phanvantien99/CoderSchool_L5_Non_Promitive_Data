namespace non_primitive_data_types_q4_classes;

abstract class Items
{
    private int id;
    private string name;
    private int quantity;



    public required int Id { get => id; init => id = value; }
    public required int Quantity { get => quantity; set => quantity = value; }
    public string Name { get => name; set => name = value; }
}