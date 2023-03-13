namespace _3.Sem_OOP_1
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public double Price { get; set; }
        public string? LicensePlate { get; set; }

        public void Validate()
        {
            ValidateModel();
            ValidatePrice();
            ValidateLicensePlate();
        }

        public void ValidateModel()
        {
            if (Model == null)
            {
                throw new ArgumentNullException();
            }

            if (Model.Length < 4) 
            {
                throw new ArgumentException();
            }
        }

        public void ValidatePrice()
        {
            if (Price < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void ValidateLicensePlate()
        {
            if (LicensePlate == null)
            {
                throw new ArgumentNullException();
            }

            if (LicensePlate!.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (LicensePlate!.Length > 7)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return $"{Id} {Model} {Price} {LicensePlate}";
        }
    }
}