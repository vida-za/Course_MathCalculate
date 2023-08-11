#include "Math.h"

Math::Math()
{
	sExpression = " ";
	sResult = " ";
	dResult = 0.0;
}

Math::Math(std::string expr)
{
	sExpression = expr;

	for (int i = 0; i < sExpression.length(); i++)
		vExpression.push_back(sExpression[i]);

	std::vector<char> cTemp;
    while (!vExpression.empty())
    {
        char CurrentCharExpression = '?';
        char CurrentCharTemp = '?';
        CurrentCharExpression = vExpression[0];
        if (!cTemp.empty()) CurrentCharTemp = ViewLastElement(cTemp);
        if (isdigit(CurrentCharExpression))
        {
            vPostfixExpr.push_back(CurrentCharExpression);
            DeleteFirstElement(vExpression);
        }
        else if (CurrentCharExpression == '(')
        {
            cTemp.push_back(CurrentCharExpression);
            DeleteFirstElement(vExpression);
        }
        else if (CurrentCharExpression == ')')
        {
            while (cTemp.size() > 0 && CurrentCharTemp != '(')
            {
                vPostfixExpr.push_back(CurrentCharTemp);
                DeleteLastElement(cTemp);
                if (!cTemp.empty()) CurrentCharTemp = ViewLastElement(cTemp);
            }
            DeleteLastElement(cTemp);
            DeleteFirstElement(vExpression);
        }
        else if (Priority(CurrentCharExpression) != -1)
        {
            while (cTemp.size() > 0 && Priority(CurrentCharTemp) >= Priority(CurrentCharExpression))
            {
                vPostfixExpr.push_back(CurrentCharTemp);
                DeleteLastElement(cTemp);
                if (!cTemp.empty()) CurrentCharTemp = ViewLastElement(cTemp);
            }
            cTemp.push_back(CurrentCharExpression);
            DeleteFirstElement(vExpression);
        }
    }
    while (!cTemp.empty())
    {
        vPostfixExpr.push_back(ViewLastElement(cTemp));
        DeleteLastElement(cTemp);
    }

    std::vector<double> dTemp;
    for (int i = 0; i < vPostfixExpr.size(); i++)
    {
        double tmp = 0;
        if (isdigit(vPostfixExpr[i]))
        {
            dTemp.push_back(vPostfixExpr[i] - '0');
        }
        else
        {
            switch (vPostfixExpr[i])
            {
            case '+': tmp = dTemp[dTemp.size() - 2] + dTemp[dTemp.size() - 1]; break;
            case '-': tmp = dTemp[dTemp.size() - 2] - dTemp[dTemp.size() - 1]; break;
            case '*': tmp = dTemp[dTemp.size() - 2] * dTemp[dTemp.size() - 1]; break;
            case '/': tmp = dTemp[dTemp.size() - 2] / dTemp[dTemp.size() - 1]; break;
            case '^': tmp = pow(dTemp[dTemp.size() - 2], dTemp[dTemp.size() - 1]); break;
            default: break;
            }
            DeleteLastElement(dTemp);
            DeleteLastElement(dTemp);
            dTemp.push_back(tmp);
        }
    }
    if (!dTemp.empty())
    {
        dResult = dTemp[0];
        sResult = std::to_string(dResult);
    }
    else
    {
        dResult = 0.0;
        sResult = "Null";
    }
    dTemp.clear();
}

Math::~Math()
{
}

std::string Math::StringPostfixExpr()
{
    if (vPostfixExpr.empty()) return "Null";
    else
    {
        std::string sPostfix = "";
        for (int i = 0; i < vPostfixExpr.size(); i++)
            sPostfix += vPostfixExpr[i];
        return sPostfix;
    }
}

std::string Math::StringResult()
{
    return sResult;
}

int Priority(char op)
{
    int p;
    switch (op)
    {
    case '(': p = 0; break;
    case '+': p = 1; break;
    case '-': p = 1; break;
    case '*': p = 2; break;
    case '/': p = 2; break;
    case '^': p = 3; break;
    default: p = -1; break;
    }
    return p;
}