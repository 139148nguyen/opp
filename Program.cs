class Program
{
    static void Main(string[] args)
    {
        //Car myObj = new Car();
        //Console.WriteLine(myObj.color);
        //Console.WriteLine(myObj.maxSpeed);

        //Car Ford = new Car();
        //Ford.model = "Mustang";
        //Ford.color = "red";
        //Ford.year = 1969;

        //Car Opel = new Car();
        //Opel.model = "Astra";
        //Opel.color = "white";
        //Opel.year = 2005;

        //Console.WriteLine(Ford.model);
        //Console.WriteLine(Opel.model);

        //Car Ford_new = new Car();
        //Console.WriteLine(Ford_new.model);
        //Car Ford = new Car("Mustang");
        //Console.WriteLine(Ford.model);
       
        Car myCar = new Car();
        myCar.honk();
        Console.WriteLine(myCar.brand + " " + myCar.modelName);


    }
}