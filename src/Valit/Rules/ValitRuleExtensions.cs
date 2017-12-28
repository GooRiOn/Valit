using System.Collections.Generic;
using System.Linq;
using Valit.Exceptions;
using Valit.Result;

namespace Valit.Rules
{
    internal static  class ValitRuleExtensions
    {
        internal static IValitResult ValidateRules<TObject>(this IEnumerable<IValitRule<TObject>> rules, IValitStrategy strategy, TObject @object) where TObject : class
        {
            rules.ThrowIfNull();

            var result = ValitResult.Success;

            foreach (var rule in rules.ToList())
            {
                (IValitResult ruleResult, bool cancel) = ValidateRule(rule, strategy, @object);
                result &= ruleResult;
                if (cancel)
                {
                    break;
                }
            }

            strategy.Done(result);

            return result;
        }

        private static (IValitResult, bool) ValidateRule<TObject>(IValitRule<TObject> rule, IValitStrategy strategy, TObject @object) where TObject : class
        {
            var result = ValitResult.Success;
            var cancelValidation = false;
            var ensureRules = rule is IValitRuleAccessor<TObject> ?
                rule.GetAccessor().GetEnsureRules(@object) :
                new[] { rule };
            foreach (var ensureRule in ensureRules)
            {
                result &= ensureRule.Validate(@object);
                if (!result.Succeeded)
                {
                    strategy.Fail(ensureRule, result, out bool cancel);
                    if (cancel)
                    {
                        cancelValidation = true;
                        break;
                    }
                }
            }
            return (result, cancelValidation);
        }
    }
}
