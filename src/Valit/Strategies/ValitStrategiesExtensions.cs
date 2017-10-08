using System;
using Valit.Strategies;

namespace Valit
{
    public static class ValitStrategyExtensions
    {
        public static IValitRules<TObject> WithStrategy<TObject>(this IValitRulesStrategyPicker<TObject> that, Func<DefaultValitStrategies, IValitStrategy> picker)
            where TObject : class
        {
            var strat = picker(default(DefaultValitStrategies));

            return ValitRules<TObject>.Create().WithStrategy(strat);
        }
    }
}