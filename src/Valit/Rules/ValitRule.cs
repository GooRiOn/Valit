﻿using System;
using System.Collections.Generic;
using Valit.Strategies;

namespace Valit
{
    internal class ValitRule<TObject, TProperty> : IValitRule<TObject, TProperty>, IValitRuleAccessor<TObject, TProperty> where TObject : class
    {
		public IValitStrategy Strategy { get; }
        public IEnumerable<string> Tags => _tags;

        Func<TObject, TProperty> IValitRuleAccessor<TObject, TProperty>.PropertySelector => _propertySelector;
        IValitRule<TObject, TProperty> IValitRuleAccessor<TObject, TProperty>.PreviousRule => _previousRule;

		private readonly Func<TObject, TProperty> _propertySelector;
        private Predicate<TProperty> _predicate;
        private readonly List<Predicate<TObject>> _conditions;
        private readonly IValitRule<TObject, TProperty> _previousRule;
		private readonly List<ValitRuleError> _errors;
        private readonly List<string> _tags;

        internal ValitRule(IValitRule<TObject, TProperty> previousRule) : this()
        {
            var previousRuleAccessor = previousRule.GetAccessor();
            _propertySelector = previousRuleAccessor.PropertySelector;
            _previousRule = previousRule;
            Strategy = previousRule.Strategy;
        }

        internal ValitRule(Func<TObject, TProperty> propertySelector, IValitStrategy strategy) : this()
        {
            _propertySelector = propertySelector;
            Strategy = strategy;
        }

        private ValitRule()
        {        
            _errors = new List<ValitRuleError>();
            _conditions = new List<Predicate<TObject>>();
            _tags = new List<string>();
        }		

		void IValitRuleAccessor<TObject, TProperty>.SetPredicate(Predicate<TProperty> predicate)
            => _predicate = predicate;

		void IValitRuleAccessor.AddError(ValitRuleError error)
            => _errors.Add(error);

		void IValitRuleAccessor<TObject, TProperty>.AddCondition(Predicate<TObject> condition)
            => _conditions.Add(condition);		

		void IValitRuleAccessor.AddTags(params string[] tags)
            => _tags.AddRange(tags);

		public IValitResult Validate(TObject @object)
		{
            var property = _propertySelector(@object);
			var hasAllConditionsFulfilled = true;

            foreach(var condition in _conditions)
                hasAllConditionsFulfilled &= condition(@object);

            var isSatisfied = _predicate?.Invoke(property) != false;

            return hasAllConditionsFulfilled && isSatisfied ? ValitResult.Success : ValitResult.Fail(_errors.ToArray());		
        }
	}
}
