// © SS220, An EULA/CLA with a hosting restriction, full text: https://raw.githubusercontent.com/SerbiaStrong-220/space-station-14/master/CLA.txt
using Content.Client.SS220.CultYogg.MiGo;
using System.Numerics;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;

namespace Content.Client.SS220.CultYogg.MiGo.UI;

[GenerateTypedNameReferences]
public sealed partial class MiGoErectMaterialView : Control
{
    public Vector2 IconScale
    {
        get => ItemView.DisplayRect.TextureScale;
        set => ItemView.DisplayRect.TextureScale = value;
    }

    public MiGoErectMaterialView()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);
    }

    public void SetItem(SpriteSpecifier sprite, int? stackCount)
    {
        ItemView.SetFromSpriteSpecifier(sprite);
        var countText = stackCount.HasValue && stackCount.Value > 1 ? stackCount.Value.ToString() : "";
        CountLabel.Text = countText;
    }
}
