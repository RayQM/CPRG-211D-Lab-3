namespace CPRG211_D_Lab3
{
    internal interface IAnimal
    {
        string Colour { get; set; }
        string Name { get; set; }

        void Eat();
        string FormListCat();
        string FormListDog();
    }
}