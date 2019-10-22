namespace AssociationOneToOneExample
{
    class Address
    {
        public Address()
        {
        }

        public Address(string houseNo, string roadNo, string ward, int postCode, string district) : this()
        {
            HouseNo = houseNo;
            RoadNo = roadNo;
            Ward = ward;
            PostCode = postCode;
            District = district;
        }

        public string HouseNo { set; get; }
        public string RoadNo { set; get; }
        public string Ward { set; get; }
        public int PostCode { set; get; }
        public string District { set; get; }
    }
}
