# <center>***README***</center>

----

## 测试目的  
 
 	最近在编写AlgorithmManager类时发现一个问题，因为AlgorithmManager是管理算法的，所以该类中就要有一个List<Algorithm>列表对   
 	象用于存储算法，可是在想到我要遍历算法时还要在AlgorithmManager中增加一个属性用于暴露List<Algorithm>对象，否则在该类的外部无法遍历算法，  
	但是又想到在遍历List本身时是不需要List对象暴露一个内部对象的属性出来的，所以在网上查了下List类实现了IEnumerable和IEnumerator两个接口，  
	所以该测试的目的是要搞清楚这两个接口是什么原理以及怎么用。   

### 测试内容   

1：[2020-6-14 19:59] 添加“IEnumerableAndIEnumerator测试”测试项目，主要测试IEnumerable和IEnumerator接口，并且熟悉了索引器使用方法。  

2：
