namespace abstract_factory.Abstractions
{
    public interface IFactory
    {
        IComputer CreateComputer();
        IMobilePhone CreateMobilePhone();
    }
}
