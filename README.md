# AsyncStreamsInCShaper8.0

很开心今天能与大家一起聊聊C# 8.0中的新特性-`Async Stream`,一般人通常看到这个词表情是这样.  
<img src="https://raw.githubusercontent.com/liuzhenyulive/AsyncStreamsInCShaper8.0/master/Pic/mengbi.jpg" width="100" height="100"/>  
简单说,其实就是C# 8.0中支持`await foreach`.  
<img src="https://raw.githubusercontent.com/liuzhenyulive/AsyncStreamsInCShaper8.0/master/Pic/mengbi2.jpg" width="100" height="100"/>  
或者说,C# 8.0中支持异步返回枚举类型`async Task<IEnumerable<T>>`.  
<img src="https://raw.githubusercontent.com/liuzhenyulive/AsyncStreamsInCShaper8.0/master/Pic/mengbi3.jpeg" width="100" height="100"/>   
好吧,还不懂?Good,这篇文章就是为你写的了.  

`await foreach`, 这个功能已经发布很久了,在去年的[Build 2018 The future of C#](https://channel9.msdn.com/Events/Build/2018/BRK2155)就有演示,最近VS 2019发布,在该版本的[Release Notes](https://docs.microsoft.com/en-us/visualstudio/releases/2019/release-notes)中,我再次看到了这个新特性,因为对异步编程不太熟悉,所以借着这个机会,学习新特性的同时,把异步编程也过一遍.
