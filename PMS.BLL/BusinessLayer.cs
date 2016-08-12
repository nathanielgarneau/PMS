using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMS.BLL
{
    public class BusinessLayer
    {
        public BusinessLayer()
        {
        }

        private Address _address { get; set; }
        public Address Address => _address ?? (_address = new Address());

        private City _city { get; set; }
        public City City => _city ?? (_city = new City());

        private Client _client { get; set; }
        public Client Client => _client ?? (_client = new Client());

        private Colour _colour { get; set; }
        public Colour Colour => _colour ?? (_colour = new Colour());

        private Condition _condition { get; set; }
        public Condition Condition => _condition ?? (_condition = new Condition());
        private Country _country { get; set; }
        public Country Country => _country ?? (_country = new Country());

        private Facility _facility { get; set; }
        public Facility Facility => _facility ?? (_facility = new Facility());
        private IdentificationType _identificationType { get; set; }
        public IdentificationType IdentificationType => _identificationType ?? (_identificationType = new IdentificationType());
        private Location _location { get; set; }
        public Location Location => _location ?? (_location = new Location());

        private Note _note { get; set; }
        public Note Note => _note ?? (_note = new Note());
        private Pawn _pawn { get; set; }
        public Pawn Pawn => _pawn ?? (_pawn = new Pawn());

        private Payment _payment { get; set; }
        public Payment Payment => _payment ?? (_payment = new Payment());
        private PaymentType _paymentType { get; set; }
        public PaymentType PaymentType => _paymentType ?? (_paymentType = new PaymentType());

        private Product _product { get; set; }
        public Product Product => _product ?? (_product = new Product());
        private ProductType _productType { get; set; }
        public ProductType ProductType => _productType ?? (_productType = new ProductType());
        private Province _province { get; set; }
        public Province Province => _province ?? (_province = new Province());
        private Purchase _purchase { get; set; }
        public Purchase Purchase => _purchase ?? (_purchase = new Purchase());
        private Rate _rate { get; set; }
        public Rate Rate => _rate ?? (_rate = new Rate());


        private Product _setting { get; set; }
        public Product Setting => _setting ?? (_setting = new Product());
        private Tag _tag { get; set; }
        public Tag Tag => _tag ?? (_tag = new Tag());

        private User _user { get; set; }
        public User User => _user ?? (_user = new User());

        private UserSettings _userSettings { get; set; }
        public UserSettings UserSettings => _userSettings ?? (_userSettings = new UserSettings());



    }
}
