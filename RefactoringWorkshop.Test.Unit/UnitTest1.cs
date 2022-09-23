namespace RefactoringWorkshop.Test.Unit;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var tp = new TemplateProcessor.TemplateProcessor();
        var sourceTemplate = "";
        var reqId = "";
        var code = "";

        Assert.Throws<ArgumentOutOfRangeException>(() => tp.process(sourceTemplate,reqId,code));
    }
}