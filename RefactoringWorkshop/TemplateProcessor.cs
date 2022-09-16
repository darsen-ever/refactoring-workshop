using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace TemplateProcessor
{
/**
 * Hello world!
 * 
 */
public class TemplateProcessor {

	public String process(String sourceTemplate, String reqId, String code) {

		String template = sourceTemplate;

		// Substitute for %CODE%
		int templateSplitBegin = template.IndexOf("%CODE%");
		int templateSplitEnd = templateSplitBegin + 6;
		String templatePartOne = template.Substring(0,
				templateSplitBegin);
        String templatePartTwo = template.Substring(templateSplitEnd, template.Length - templateSplitEnd);
		code = reqId;
		//StringBuilder sb = new StringBuilder();
		//sb.append(templatePartOne).append(code).append(templatePartTwo);
		template = templatePartOne + code + templatePartTwo;

		// Substitute for %ALTCODE%
		templateSplitBegin = template.IndexOf("%ALTCODE%");
		templateSplitEnd = templateSplitBegin + 9;
		templatePartOne = template.Substring(0, templateSplitBegin);
		templatePartTwo = template.Substring(templateSplitEnd,
                template.Length - templateSplitEnd);
		String altcode = code.Substring(0, 5) + "-" + code.Substring(5, 3);
		return templatePartOne + altcode + templatePartTwo;

	}

}

}
