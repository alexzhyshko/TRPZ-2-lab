using System;

namespace TaxiWPF.dto
{
    class OrderDTO
    {
        DriverDTO driver;
        CarDTO car;
        UserDTO user;
        DateTime orderTimestamp;

        public OrderDTO(DriverDTO driver, CarDTO car, UserDTO user, DateTime orderTimestamp)
        {
            this.driver = driver;
            this.car = car;
            this.user = user;
            this.orderTimestamp = orderTimestamp;
        }

    }
}
