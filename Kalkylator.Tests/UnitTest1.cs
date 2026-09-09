using Kalkylator;
public class RaknareTests
{
[Fact]
public void Addera_TvaPlusTre_BlirFem()
{
var raknare = new Raknare();
Assert.Equal(5, raknare.Addera(2, 3));
}
}
