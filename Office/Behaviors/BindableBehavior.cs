using System;
using Xamarin.Forms;

namespace Office.Behaviors
{
    public class BindableBehavior<T> : Behavior<T> where T: BindableObject
    {
        public T AssociatedObject { get; private set; }

        protected override void OnAttachedTo(T visualElement)
        {
            base.OnAttachedTo(visualElement);

            AssociatedObject = visualElement;
            if(visualElement.BindingContext != null)
            {
                BindingContext = visualElement.BindingContext;
            }

            visualElement.BindingContextChanged += OnBindingContextChanged;
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }

        protected override void OnDetachingFrom(T bindable)
        {
           bindable.BindingContextChanged -= OnBindingContextChanged;
        }

    }
}
