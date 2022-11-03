namespace lab10;
public interface LinearVectors
{
    void getData();
    void printArr();
    void Calcul2();

}
public abstract class vectorFactory
{
    protected abstract LinearVectors makeVectorProduct();

    public LinearVectors createVectorProduct()
    {
        return this.makeVectorProduct();
    }
}
public class vector2Factory : vectorFactory
{
    protected override LinearVectors makeVectorProduct()
    {
        LinearVectors product = new Vector2();
        return product;

    }
}
public class vector3Factory : vectorFactory
{
    protected override LinearVectors makeVectorProduct()
    {
        LinearVectors product = new Vector3();
        return product;

    }
}