namespace Delegate;
class Adrian
{
    public GetSecretIngredient MySecretIngredientMethod
    {
        get
        {
            return AddAdriansSecretIngredient;
        }
    }
    private string AddAdriansSecretIngredient(int amount)
    {
        return $"{amount} ounces of cloves";
    }
}
