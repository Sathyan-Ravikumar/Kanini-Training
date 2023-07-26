using Singleton;

VehicleFactory vf = VehicleFactory.Instance;
Vehicle car = vf.CreateVehicle("car");
Vehicle bike = vf.CreateVehicle("bike");

car.Drive();
bike.Drive();

Vehicle car2 = vf.CreateVehicle("cr");
car2.Drive();