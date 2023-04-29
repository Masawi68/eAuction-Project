using eAuction.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

namespace eAuction.Data
{
	public class AppDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder) 
		{
			using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())

			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				context.Database.EnsureCreated();

				//Product
				if (!context.Product.Any())
				{
					context.Product.AddRange(new List<Products>()
					{
						new Products()
						{
							LotNumber = 001,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Clothing/jeans.jpg",
							ProductCategory = (Enum.ProductCategory)1,
							Brand = "jeans",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},

						new Products()
						{
							LotNumber = 002,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Clothing/jersey.jpg",
							ProductCategory = (Enum.ProductCategory)1,
							Brand = "jersey",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},
						new Products()
						{
							LotNumber = 003,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Clothing/sneakers.jpg",
							ProductCategory = (Enum.ProductCategory)1,
							Brand = "sneakers",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},
						new Products()
						{
							LotNumber = 004,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Electricals/hair+clipper.jpg",
							ProductCategory = (Enum.ProductCategory)2,
							Brand = "hair clipper",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},

						new Products()
						{
							LotNumber = 005,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Electricals/kettle.jpg",
							ProductCategory = (Enum.ProductCategory)2,
							Brand = "kettle",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},
						new Products()
						{
							LotNumber = 006,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Electricals/monitor.jpg",
							ProductCategory = (Enum.ProductCategory)2,
							Brand = "monitor",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},
						new Products()
						{
							LotNumber = 007,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Furniture/chair.jpg",
							ProductCategory = (Enum.ProductCategory)3,
							Brand = "chair",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},
						new Products()
						{
							LotNumber = 008,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Furniture/sofa.jpg",
							ProductCategory = (Enum.ProductCategory)3,
							Brand = "sofa",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						},
						new Products()
						{
							LotNumber = 009,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Products/Furniture/table+%26+chairs.jpg",
							ProductCategory = (Enum.ProductCategory)3,
							Brand = "table & chairs",
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 100.00
						}

					});
					context.SaveChanges();

				}
				//DigitalGood
				if (!context.DigitalGood.Any())
				{
					context.DigitalGood.AddRange(new List<DigitalGoods>()
					{
						new DigitalGoods()
						{
							LotNumber = 010,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/eBooks/Aaron's+Rod.jpg",
							DigitalCategory = (Enum.DigitalCategory)1,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 011,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/eBooks/In+Dark+Water.jpg",
							DigitalCategory = (Enum.DigitalCategory)1,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 012,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/eBooks/The+War+of+the+Worlds.jpg",
							DigitalCategory = (Enum.DigitalCategory)1,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 013,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/Music/Acoustic+Blues+Sessions.jpg",
							DigitalCategory = (Enum.DigitalCategory)2,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 014,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/Music/Dust+My+Broom.jpg",
							DigitalCategory = (Enum.DigitalCategory)2,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 015,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/Music/King+Pride.jpg",
							DigitalCategory = (Enum.DigitalCategory)2,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 016,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/Movies/Acidman+(2022).jpg",
							DigitalCategory = (Enum.DigitalCategory)3,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 017,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/Movies/Mighty+Morphin+Power+Rangers+Once+%26+Always+(2023).jpg",
							DigitalCategory = (Enum.DigitalCategory)3,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						},
						new DigitalGoods()
						{
							LotNumber = 018,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/DigitalGoods/Movies/Ricky+(2009).jpg",
							DigitalCategory = (Enum.DigitalCategory)3,
							Discription = "This is a description of the product",
							Condition = "New",
							StartBidPrice = 10.00
						}
					});
					context.SaveChanges();
				}
				//Service
				if (!context.Service.Any())
				{
					context.Service.AddRange(new List<Services>()
					{
						new Services()
						{
							LotNumber = 019,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Website+Design/Drupaz+Webservices.jpg",
							ServiceCategory = (Enum.ServiceCategory)1,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2006-01-01),
							StartBidPrice = 10.00
						},
						new Services()
						{
							LotNumber = 020,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Website+Design/IT+Masters.jpg",
							ServiceCategory = (Enum.ServiceCategory)1,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2010-05-01),
							StartBidPrice = 20.00
						},
						new Services()
						{
							LotNumber = 021,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Website+Design/IT+solutions.jpg",
							ServiceCategory = (Enum.ServiceCategory)1,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2007-04-01),
							StartBidPrice = 20.00
						},
						new Services()
						{
							LotNumber = 022,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Writing+services/Global+writing+services.jpg",
							ServiceCategory = (Enum.ServiceCategory)2,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2007-04-01),
							StartBidPrice = 20.00
						},
						new Services()
						{
							LotNumber = 023,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Writing+services/Guru+writing+services.jpg",
							ServiceCategory = (Enum.ServiceCategory)2,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2007-04-01),
							StartBidPrice = 20.00
						},
						new Services()
						{
							LotNumber = 024,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Writing+services/SaveMore+services.jpg",
							ServiceCategory = (Enum.ServiceCategory)2,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2011-04-01),
							StartBidPrice = 20.00
						},
						new Services()
						{
							LotNumber = 025,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Cleaning/DFY+cleaners.jpg",
							ServiceCategory = (Enum.ServiceCategory)3,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2017-04-01),
							StartBidPrice = 20.00
						},
						new Services()
						{
							LotNumber = 026,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Cleaning/Fast+Clean.jpg",
							ServiceCategory = (Enum.ServiceCategory)3,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2007-03-12),
							StartBidPrice = 20.00
						},
						new Services()
						{
							LotNumber = 027,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Service/Cleaning/Hygien+Cleaning.jpg",
							ServiceCategory = (Enum.ServiceCategory)3,
							Discription = "This is a description of the product",
							YearsOfExpirience = (DateFormat)(2009-07-01),
							StartBidPrice = 20.00
						}
					});
					context.SaveChanges();
				}
				
				//Vehicles
				if (!context.Vehicles.Any())
				{
					context.Vehicles.AddRange(new List<Vehicle>()
					{
						new Vehicle()
						{
							LotNumber = 028,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/Benz.jpg",

                            VehicleCategory = (Enum.VehicleCategory)1,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2012-01-01),
							Make = "Benz",
							Model = "B74i",
							StartBidPrice = 2000.00
						},
						new Vehicle()
						{
							LotNumber = 029,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/BMW.jpg",
							VehicleCategory = (Enum.VehicleCategory)1,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2012-01-01),
							Make = "BMW",
							Model = "i359z",
							StartBidPrice = 2000.00
						},
						new Vehicle()
						{
							LotNumber = 030,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/Ferari.jpg",
							VehicleCategory = (Enum.VehicleCategory)1,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2015-01-01),
							Make = "Ferari",
							Model = "F23",
							StartBidPrice = 10000.00
						},
						new Vehicle()
						{
							LotNumber = 031,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/Trucks/Chevrolet.jpg",
							VehicleCategory = (Enum.VehicleCategory)2,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2022-01-01),
							Make = "Chevrolet",
							Model = "Tere 0.4",
							StartBidPrice = 10000.00
						},
						new Vehicle()
						{
							LotNumber = 032,
							ProductPicURL ="https://media-ed.s3.amazonaws.com/Media/Vehicles/Trucks/Chevrolet_2.jpg",
							VehicleCategory = (Enum.VehicleCategory)2,
							Discription = "This is a description of the product",
							Year = (DateFormat)(1996-01-01),
							Make = "Chevrolet",
							Model = "clare",
							StartBidPrice = 1000.00
						},
						new Vehicle()
						{
							LotNumber = 033,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/Trucks/Chevrolet_3.jpg",
							VehicleCategory = (Enum.VehicleCategory)2,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2019-01-01),
							Make = "Chevrolet",
							Model = "Rev-22",
							StartBidPrice = 12000.00
						},
						new Vehicle()
						{
							LotNumber = 034,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/MotorCycle/harley-davidson.jpg",
							VehicleCategory = (Enum.VehicleCategory)3,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2018-01-01),
							Make = "harley-davidson",
							Model = "BTF19",
							StartBidPrice = 1500.00
						},
						new Vehicle()
						{
							LotNumber = 035,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/MotorCycle/Honda.jpg",
							VehicleCategory = (Enum.VehicleCategory)3,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2019-01-01),
							Make = "Honda",
							Model = "Ducati",
							StartBidPrice = 1200.00
						},
						new Vehicle()
						{
							LotNumber = 036,
							ProductPicURL = "https://media-ed.s3.amazonaws.com/Media/Vehicles/cars/Ferari.jpg",
							VehicleCategory = (Enum.VehicleCategory)3,
							Discription = "This is a description of the product",
							Year = (DateFormat)(2015-01-01),
							Make = "Yamaha",
							Model = "R1",
							StartBidPrice = 1000.00
						}
					});
					context.SaveChanges();
				}

			}
		}
	}

}
