using System;

class TrainSignal
{
    public event Action TrainsAComing;

    public void HereComesATrain()
    {
        Console.WriteLine("Here comes the train!!");
        TrainsAComing?.Invoke();
    }
}

class Car
{
    public Car(TrainSignal trainSignal)
    {
        trainSignal.TrainsAComing += StopTheCar;
    }

    void StopTheCar()
    {
        Console.WriteLine("SCREEEEEEECH");
    }
}

class Baby
{
    public Baby(TrainSignal trainSignal)
    {
        trainSignal.TrainsAComing += Cry;
    }

    void Cry()
    {
        Console.WriteLine("WAAAAAAAAA");
    }
}

class MainClass
{
    static void Main()
    {
        TrainSignal trainSignal = new TrainSignal();
        new Car(trainSignal);
        new Car(trainSignal);
        new Baby(trainSignal);
        trainSignal.HereComesATrain();
        trainSignal.HereComesATrain();
    }
}