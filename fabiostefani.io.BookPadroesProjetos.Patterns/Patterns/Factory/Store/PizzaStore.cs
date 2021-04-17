using fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory.Model;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(EnumTypePizza typePizza)
        {
            Pizza pizza = CreatePizza(typePizza);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza CreatePizza(EnumTypePizza typePizza);
    }
}
