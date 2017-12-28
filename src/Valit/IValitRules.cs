using System;
using System.Collections.Generic;

namespace Valit
{
    public interface IValitRules<TObject> where TObject : class
    {
        IValitRules<TObject> Ensure<TProperty>(Func<TObject, TProperty> selector, Func<IValitRule<TObject, TProperty>, IValitRule<TObject, TProperty>> ruleFunc);
        IValitRules<TObject> Ensure<TProperty>(Func<TObject, TProperty> selector, IValitator<TProperty> valitator) where TProperty : class;
        IValitRules<TObject> Ensure<TProperty>(Func<TObject, TProperty> selector, Func<IValitRule<TObject, TProperty>, TObject, IValitRule<TObject, TProperty>> rule);
        IValitRules<TObject> EnsureFor<TProperty>(Func<TObject, IEnumerable<TProperty>> selector, Func<IValitRule<TObject, TProperty>, IValitRule<TObject, TProperty>> ruleFunc);
        IValitRules<TObject> EnsureFor<TProperty>(Func<TObject, IEnumerable<TProperty>> selector, IValitator<TProperty> valitator) where TProperty : class;
        IValitRules<TObject> For(TObject @object);
        IEnumerable<IValitRule<TObject>> GetAllRules();
        IEnumerable<IValitRule<TObject>> GetTaggedRules();
        IEnumerable<IValitRule<TObject>> GetUntaggedRules();
        IValitResult Validate();
        IValitResult Validate(params string[] tags);
        IValitResult Validate(Func<IValitRule<TObject>, bool> predicate);
    }
}
