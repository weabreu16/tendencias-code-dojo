namespace KataMeshWord.test;

public class UnitTest1
{
    [Fact]
    public void should_return_chaoslaa_if_receive_casa_and_hola()
    {
        MeshWord meshWord = new MeshWord();
        string result = meshWord.MergeWords("casa", "hola");
        Assert.That(result, Is.EqualTo("chaoslaa"));
    }
}