namespace RefactoringWorkshop.Test.Unit;

public class TemplateProcessorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenEmptyParametersOnprocessThenArgumentOutOfRangeException()
    {
        var tp = new TemplateProcessor.TemplateProcessor();
        var sourceTemplate = "";
        var reqId = "";
        var code = "";

        Assert.Throws<ArgumentOutOfRangeException>(() => tp.process(sourceTemplate,reqId,code));
    }

    [Test]
    public void GivenEmptySecondParametersOnprocessThenArgumentOutOfRangeException()
    {
        var tp = new TemplateProcessor.TemplateProcessor();
        var sourceTemplate = "%CODE%";
        var reqId = "";
        var code = "";

        Assert.Throws<ArgumentOutOfRangeException>(() => tp.process(sourceTemplate,reqId,code));
    }

    [Test]
    public void GivenEmptyCodeParametersOnprocessThenArgumentOutOfRangeException()
    {
        var tp = new TemplateProcessor.TemplateProcessor();
        var sourceTemplate = "%CODE%%ALTCODE%";
        var reqId = "";
        var code = "";

        Assert.Throws<ArgumentOutOfRangeException>(() => tp.process(sourceTemplate,reqId,code));
    }

    [Test]
    public void GivenCodeParametersOnprocessThenArgumentOutOfRangeException()
    {
        var tp = new TemplateProcessor.TemplateProcessor();
        var sourceTemplate = "%CODE%%ALTCODE%";
        var reqId = "123456789";
        var code = "";

        var result = tp.process(sourceTemplate,reqId,code);

        Assert.AreEqual("12345678912345-678", result);
    }

    [Test]
    public void GivenNullParametersOnprocessThenSystemNullReferenceException()
    {
        var tp = new TemplateProcessor.TemplateProcessor();
        string? sourceTemplate = null;
        string? reqId = null;
        string? code = null;

        Assert.Throws<System.NullReferenceException>(() => tp.process(sourceTemplate,reqId,code));
    }
}
