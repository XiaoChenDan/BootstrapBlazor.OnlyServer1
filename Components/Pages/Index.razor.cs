using BootstrapBlazor.Components;
using BootstrapBlazor.OnlyServer1.Data;

namespace BootstrapBlazor.OnlyServer1.Components.Pages
{
    public partial class Index
    {
        private List<Foo>? Items { get; set; }

        private bool ShowDialog { get; set; } = false;

        private string DialogStyleString => ShowDialog ? "display:flex;" : "display:none;";

        protected override void OnInitialized()
        {
            base.OnInitialized();
            //获取随机数据
            //Get random data
            Items = Foo.GenerateFoo(FooLocalizer);
        }

        private void OpenDialog()
        {
            ShowDialog = !ShowDialog;
            StateHasChanged();
        }
    }
}
