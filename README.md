# WPF-QuestThemeUI

#### 介绍
模仿网页版UI布局，使用WPF进行布局和功能练习。实现了界面布局、转换器、控件模板、触发器、主题切换、数据绑定等功能。一套做下来能加深对WPF的基本功能入门级别认识，熟能生巧。
环境：VS2019 + .NET 5

#### 软件说明
模仿网页的地址：https://demos.creative-tim.com/bootstrap-wizard/index.html

主题切换只实现了背景切换，没有按网页版的进行内容替换，多准备几个Page或window 即可。
由于Mvvm.Light 不完全支持 .NET 5，所以自行实现了 ICommand 和 INotifyPropertyChanged，用于命令事件绑定和数据绑定。

#### 已实现功能

1.  数据双向绑定
2.  页面切换（不过使用Frame 切换会有声音，暂不清楚如何去掉）
3.  数据验证 ValidationTemplate 
4.  属性转换器 
5.  主题背景切换 （Grid.Backgroud.ItemSource 竟然不支持 Binding Converter，总提示相对路径错误，而Image.Source 却正常，只能先使用 静态资源绑定 + 触发器 处理了）
6.  数据触发器
7.  本地图片读取

#### 问题

1. 模型验证，使用了Validator.TryValidateObject ，能手动触发验证，但是没有办法触发界面的 ValidationException，目前还没有找到办法
2. Grid 背景替换， 使用动态绑定且使用Converter 转换，会报路径错误；于是使用了静态资源，如上所述 

#### 效果图

> 原始效果图存放在 EffectPicture\Raw

> 实际效果图存放在 EffectPicture\Complete