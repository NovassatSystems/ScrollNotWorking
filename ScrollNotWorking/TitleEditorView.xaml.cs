using Microsoft.Maui;

namespace ScrollNotWorking;

public partial class TitleEditorView : Grid
{
	public TitleEditorView()
	{
		InitializeComponent();
	}

    #region Title
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
           nameof(Title),
           typeof(string),
           typeof(TitleEditorView),
           default(string),
           defaultBindingMode: BindingMode.TwoWay);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    #endregion

    #region Text
    public static readonly BindableProperty TextProperty = BindableProperty.Create(
           nameof(Text), 
           typeof(string), 
           typeof(TitleEditorView), 
           default(string),
           defaultBindingMode: BindingMode.TwoWay);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    #endregion

    #region Placeholder
    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
           nameof(Placeholder),
           typeof(string),
           typeof(TitleEditorView),
           default(string),
           defaultBindingMode: BindingMode.TwoWay);

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }
    #endregion


    #region Placeholder
    public static readonly BindableProperty KeyboardProperty = BindableProperty.Create(
           nameof(Keyboard),
           typeof(Keyboard),
           typeof(TitleEditorView),
           defaultBindingMode: BindingMode.TwoWay);

    public Keyboard Keyboard
    {
        get => (Keyboard)GetValue(KeyboardProperty);
        set => SetValue(KeyboardProperty, value);
    }
    #endregion

}