namespace TaxiWPF.dto
{
    class CarDTO
    {
        int id;
        public string plate;
        public CarDTO(int id, string plate)
        {
            this.id = id;
            this.plate = plate;
        }

    }
}
