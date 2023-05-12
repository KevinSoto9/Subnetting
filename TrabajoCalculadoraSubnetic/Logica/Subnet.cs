namespace TrabajoCalculadoraSubnetic.Logica
{
    public class Subnet
    {
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string SubnetMask { get; set; }
        public string AddressRange { get; set; }
        public string BroadcastAddress { get; set; }

    
        public Subnet(string name, string size)
        {
            name = Name;
            size = Size;
        }

        public Subnet() 
        {

        }

    }
}
