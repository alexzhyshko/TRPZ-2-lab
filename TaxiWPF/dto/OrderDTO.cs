using System;

namespace TaxiWPF.dto
{
    class OrderDTO
    {
        public int id;
        public DrivingDTO driving;
        public UserDTO user;
        public DateTime orderTimestamp;
        public string departure;
        public string destination;

        public int Id { get { return id; } }
        public string Departure { get { return departure; } }
        public string Destination { get { return destination; } }
        public DateTime OrderTimestamp { get { return orderTimestamp; } }

        public OrderDTO(DrivingDTO driving, UserDTO user, DateTime orderTimestamp, string departure, string destination)
            : this(-1, driving, user, orderTimestamp, departure, destination)
        { }

        public OrderDTO(int id, DateTime orderTimestamp, string departure, string destination)
            : this(id, null, null, orderTimestamp, departure, destination)
        { }

        public OrderDTO(int id, DrivingDTO driving, UserDTO user, DateTime orderTimestamp, string departure, string destination)
        {
            this.id = id;
            this.driving = driving;
            this.user = user;
            this.orderTimestamp = orderTimestamp;
            this.departure = departure;
            this.destination = destination;
        }



    }
}
