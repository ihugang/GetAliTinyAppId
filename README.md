# GetAliTinyAppId
获取任意支付宝小程序的AppId

在工作中遇到要通过H5跳转到支付宝小程序的需求，跳转后，当小程序关闭后还要回到原来的H5页面。
如果通过支付宝小程序的直接Url，类似 飞猪 https://ur.alipay.com/3a4qIe 来访问，则小程序关闭时无法回到H5画面。
必须通过类似alipays://platformapi/startapp?appId=2018081461095002&page=pages/index/index&query=goods_id%3d101"这样的中转url来跳转。

如何获得一个支付宝小程序的appId呢？

*如果您有小工具（文档处理、代替人工的重复工作、小程序、App等）需要开发，可以联系 390652@qq.com
