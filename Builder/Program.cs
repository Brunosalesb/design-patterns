using Builder;

Kitchen kitchen = new Kitchen();
SandwichBuilder b1 = new HamburgerBuilder();
SandwichBuilder b2 = new FishBuilder();

kitchen.CreateSandwich(b1);
b1.GetSandwich();

kitchen.CreateSandwich(b2);
b2.GetSandwich();