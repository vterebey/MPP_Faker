using MPP_2.MyGenerator;

namespace MPP_2.MyFaker
{
    public class Faker : IFaker
    {
        public T Create<T>() {
            Type type = typeof(T);
            var obj = Generators.GenerateDTO(type);
            return (T)obj;
        }
    }
}
