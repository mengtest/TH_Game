// #pragma once
//�޲������� ���Ҫ�����Ļ�����Ҫ��Pawn����Ӷ�Node�����ã�����ʹ��һ��map��������
//���ʹ�õ�һ������Ļ������ƻ���ԭ���Ľṹ�����ʹ�õڶ��ֽṹ�Ļ����ͻ�����ֱ��ʹ��mapȥ�洢
// #include "Pawn.h"

// template<class T>
// class Node
// {
//     //���ǵ�Pawn����ս����ʼʱ�ͻᴴ�������Һ�����Ҫ�õ������Լ���ɾ������pawn��������ǲ����ģ�������������ṹ
//     //��ΪPawn����ǣ����������ʽ���ڣ�ͬʱ֧�ֿ��ٲ�ѯ�Լ�������ɾ
// private:
//     //��ǰ�ڵ��а���������
//     T * _data;

//     //ǰһ���ڵ�
//     Node<T> * _prev;

//     //��һ���ڵ�
//     Node<T> * _next;
// public:
//     //���������Ƴ���ǰ�Ľڵ�ʱ����
//     T* removeSelf()
//     {
//         return _data;
//     }

//     //����ǰ�Ľṹ��ӵ�������ʱ����
//     bool addTo()
//     {
//         return true;
//     }

//     T* data()
//     {
//         return _data;
//     }
// };

// //ר�Ŵ��������Node��ʹ�õ�
// class List
// {
// private:
//     //�����ͷ��㣬����ֻ��Ϊһ������Ľڵ�ʹ��
//     Node<Pawn*> _head;
// public:
//     Node<Pawn*>* remove(int index)
//     {
//         return nullptr;
//     }


// };