using BootstrapBlazor.Components;
using BootstrapBlazor.OnlyServer1.Data;

namespace BootstrapBlazor.OnlyServer1.Components.Pages
{
    public partial class Index
    {
        private static List<TreeViewItem<TreeFoo>> GetLazyItems()
        {
            var ret =new List<TreeViewItem<TreeFoo>>
            {
                new TreeViewItem<TreeFoo>(new TreeFoo())
                {
                    Text="懒加载父节点1",
                    HasChildren=true
                },
                new TreeViewItem<TreeFoo>(new TreeFoo())
                {
                    Text="懒加载父节点2",
                    HasChildren=false
                }
            };
            return ret;
        }

        private static async Task<IEnumerable<TreeViewItem<TreeFoo>>> OnExpandNodeAsync(TreeViewItem<TreeFoo> node)
        {
            await Task.Delay(800);
            var item = node.Value;
            return new TreeViewItem<TreeFoo>[]
            {
                new(new TreeFoo()
                {
                    Id = $"{item.Id}-101",
                    ParentId = item.Id
                })
                {
                    Text = "懒加载子节点1",
                    HasChildren = true
                },
                new(new TreeFoo()
                {
                    Id = $"{item.Id}-102",
                    ParentId = item.Id
                })
                {
                    Text = "懒加载子节点2",
                    CheckedState = CheckboxState.Checked
                } };
        }
    }
}
