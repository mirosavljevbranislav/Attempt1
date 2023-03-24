namespace CodeFirst.PartTwo.Data.Model
{
    public class Car
    {
        // (color, year, chassis 
        //number, brand, model)

        public int Id { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string ChassisNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int EngineId { get; set; }
    }
}
