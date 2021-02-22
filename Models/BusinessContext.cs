using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HHRRSupport.Models
{
    public class BusinessContext: DbContext
    {
        public DbSet<Business> Business { get; set; }
        public DbSet<LocalBusiness> LocalBusiness { get; set; }
        public DbSet<Campus> Campus { get; set; }

        public BusinessContext(DbContextOptions<BusinessContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region     Business Generation
            var myBusiness = new List<Business>() {
                
                new Business(){
                    Id="Clarin", 
                    BusinessName= "Telefonia Clarin"
                },
                new Business(){
                    Id="Motostar",
                    BusinessName="Telefonia Motostar"
                }
            };
            #endregion

            modelBuilder.Entity<Business>().HasData(myBusiness);

            var myLocalBusiness = LocalBusinessGenertion(myBusiness);

            modelBuilder.Entity<LocalBusiness>().HasData(myLocalBusiness);
        }

        private List<LocalBusiness> LocalBusinessGenertion(List<Business> myBusiness)
        {
            
            var myLocalBusiness = new List<LocalBusiness>() {
                new LocalBusiness() { 
                    Id="ClarinMovil",
                    CommercialName="Clarin movil",
                    LegalName="Clarin Telecomunicaciones moviles",
                    Country="Colombia",
                    Region="Nacional",
                    City="Nacional",
                    BusinessId = myBusiness[0].Id
                },
                new LocalBusiness() { 
                    Id="ClarinHogar",
                    CommercialName="Clarin Hogar",
                    LegalName="Telitex hogar",
                    Country="Colombia",
                    Region="Nacional",
                    City="Nacional",
                    BusinessId = myBusiness[0].Id
                },
                new LocalBusiness() { 
                    Id="MtorstarMovil",
                    CommercialName="Motorstar Movil",
                    LegalName="Bells and packards",
                    Country="Colombia",
                    Region="Nacional",
                    City="Nacional",
                    BusinessId = myBusiness[1].Id
                },
                new LocalBusiness() { 
                    Id="MtorstarHogar",
                    CommercialName="Motorstar Hogar",
                    LegalName="0099 hogar",
                    Country="Colombia",
                    Region="Nacional",
                    City="Nacional",
                    BusinessId = myBusiness[1].Id
                }
                
            };
           

            return myLocalBusiness;
        }
    }
}
