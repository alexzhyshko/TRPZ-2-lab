namespace TaxiWPF.dto
{
    class DrivingDTO
    {
        public int id;
        public DriverDTO driver;
        public CarDTO car;

        public DrivingDTO(int id, DriverDTO driver, CarDTO car)
        {
            this.id = id;
            this.driver = driver;
            this.car = car;
        }

    }
}
