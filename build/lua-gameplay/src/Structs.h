// #pragma once
//无病呻吟， 如果要做到的话，需要在Pawn中添加对Node的引用，或者使用一个map存起来。
//如果使用第一种情况的话，就破坏了原本的结构，如果使用第二种结构的话，就还不如直接使用map去存储
// #include "Pawn.h"

// template<class T>
// class Node
// {
//     //考虑到Pawn是在战斗开始时就会创建，并且后续需要用到查找以及增删，并且pawn本身相对是不会变的，所以增加这个结构
//     //作为Pawn的外壳，以链表的形式存在，同时支持快速查询以及快速增删
// private:
//     //当前节点中包含的数据
//     T * _data;

//     //前一个节点
//     Node<T> * _prev;

//     //下一个节点
//     Node<T> * _next;
// public:
//     //从链表中移除当前的节点时调用
//     T* removeSelf()
//     {
//         return _data;
//     }

//     //将当前的结构添加到链表中时调用
//     bool addTo()
//     {
//         return true;
//     }

//     T* data()
//     {
//         return _data;
//     }
// };

// //专门搭配上面的Node来使用的
// class List
// {
// private:
//     //链表的头结点，本身只作为一个特殊的节点使用
//     Node<Pawn*> _head;
// public:
//     Node<Pawn*>* remove(int index)
//     {
//         return nullptr;
//     }


// };