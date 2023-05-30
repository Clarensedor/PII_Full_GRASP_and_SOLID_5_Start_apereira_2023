
namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// printers ya no dependen de Recipe
    /// sino que hacemos que la interfaz no dependa de ellos.
    /// </summary>
    public interface IPrinter
    {
        void PrintRecipe(IRecipeContent recipeContent);
    }
}