using System;
namespace sample13 {

    [Flags]
     public  enum NewWonders: byte
    {
        None = 0b_0000_0000, 
        GreatPyramidOfGiza =0b_0000_0001,
        AreciboObservatory = 0b_0000_0010,
        CristoConcorvado = 0b_0000_0100,
        EiffelTower = 0b_0000_1000,
        ISS = 0b_0001_0000,
        ChichenItzaPyramid =  0b_0010_0000,
        MarianFosa =  0b_0100_0000 
    }

}