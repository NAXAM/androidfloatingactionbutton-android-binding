using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Views;
using Com.Getbase.Floatingactionbutton;

namespace AndroidFloatingActionButtonQs
{
    [Activity(Label = "AndroidFloatingActionButtonQs", MainLauncher = true, Icon = "@drawable/naxam")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);
            FindViewById(Resource.Id.pink_icon).Click += (s, e) =>
            {
                Toast.MakeText(this, "Clicked pink Floating Action Button", ToastLength.Short).Show();
            };

            FloatingActionButton button = (FloatingActionButton)FindViewById(Resource.Id.setter);
            button.Size = FloatingActionButton.SizeMini;
            button.SetColorNormalResId(Resource.Color.pink);
            button.SetColorPressedResId(Resource.Color.pink_pressed);
            button.SetIcon(Resource.Drawable.ic_fab_star);
            button.StrokeVisible = false;

            View actionB = FindViewById(Resource.Id.action_b);

            FloatingActionButton actionC = new FloatingActionButton(BaseContext);
            actionC.Title = "Hide/Show Action above";
            actionC.Click += (s, e) =>
            {
                actionB.Visibility = actionB.Visibility == ViewStates.Gone ? ViewStates.Visible : ViewStates.Invisible;
            };

            FloatingActionsMenu menuMultipleActions = (FloatingActionsMenu)FindViewById(Resource.Id.multiple_actions);
            menuMultipleActions.AddButton(actionC);

            FloatingActionButton removeAction = (FloatingActionButton)FindViewById(Resource.Id.button_remove);
            removeAction.Click += (s, e) =>
            {
                ((FloatingActionsMenu)FindViewById(Resource.Id.multiple_actions_down)).RemoveButton(removeAction);
            };

            ShapeDrawable drawable = new ShapeDrawable(new OvalShape());
            drawable.Paint.Color = (Resources.GetColor(Resource.Color.white));
            ((FloatingActionButton)FindViewById(Resource.Id.setter_drawable)).SetIconDrawable(drawable);

            FloatingActionButton actionA = (FloatingActionButton)FindViewById(Resource.Id.action_a);
            actionA.Click += (s, e) =>
            {
                actionA.Title = "Action A clicked";
            };

            // Test that FAMs containing FABs with visibility GONE do not cause crashes
            FindViewById(Resource.Id.button_gone).Visibility = Android.Views.ViewStates.Gone;

            FloatingActionButton actionEnable = (FloatingActionButton)FindViewById(Resource.Id.action_enable);
            actionEnable.Click += (s, e) =>
            {
                menuMultipleActions.Enabled = !menuMultipleActions.Enabled;
            };

            FloatingActionsMenu rightLabels = (FloatingActionsMenu)FindViewById(Resource.Id.right_labels);
            FloatingActionButton addedOnce = new FloatingActionButton(this);
            addedOnce.Title = "Added once";
            rightLabels.AddButton(addedOnce);

            FloatingActionButton addedTwice = new FloatingActionButton(this);
            addedTwice.Title = "Added twice";
            rightLabels.AddButton(addedTwice);
            rightLabels.RemoveButton(addedTwice);
            rightLabels.AddButton(addedTwice);
        }
    }
}

