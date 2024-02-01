# AutoHotKey

# Provide
* 屏幕取色
* 通过取色分析游戏数据
* 自动释放热键
* 实现类外挂功能

# How to use
* 定义技能热键
* 定义取色坐标
* 定义取色值
* 加入配置
* 运行
``` c#
public class AHKRogue : AHKRotation
{
    public override void Setup()
    {
        base.Setup();
        this.AddSkill(new AHKSkill("切割", KeyCode.Alpha1, new AHKColor(255, 0, 0), AHKPos.Center));
        this.AddSkill(new AHKSkill("影袭", KeyCode.Alpha2, new AHKColor(254, 0, 0), AHKPos.Center));
        this.AddSkill(new AHKSkill("斩击", KeyCode.Alpha3, new AHKColor(253, 0, 0), AHKPos.Center));
        this.AddGrabber(new AHKGrabberCombatPoint());
        this.AddGrabber(new AHKGrabberHPMP());
    }
}
```
