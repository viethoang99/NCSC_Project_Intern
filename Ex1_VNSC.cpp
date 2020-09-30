#include <iostream>
#include <stdlib.h>
using namespace std;

struct Node {
    unsigned long int data;
    struct Node* next;
    struct Node* prev; 
}*start, * last;
class CircularDoublyLinkedList {
public:
    Node* createNode(unsigned long int);
    void insert_begin(unsigned long int);
    void insert_end(unsigned long int);
    void insert_pos(unsigned long int, int);
    void delete_pos(int);
    void update(unsigned long int, int);
    void display();
    void reverse();
    void swap(Node*, Node*);
    void sort();
    CircularDoublyLinkedList() {
        start = NULL;
        last = NULL;
    }
    int count = 0;
};
//insert a new node
Node* CircularDoublyLinkedList::createNode(unsigned long int x) {
    struct Node* nod = new (struct Node);
    nod->data = x;
    nod->next = NULL;
    nod->prev = NULL;
    count++;
    return nod;
}

//insert at the beginning
void CircularDoublyLinkedList::insert_begin(unsigned long int x) {
    struct Node* nod;
    nod = createNode(x);
    if (start == last && start == NULL) {
        start = last = nod;
        start->next = last->next = NULL;
        start->prev = last->prev = NULL;

    }
    else {
        nod->next = start;
        start->prev = nod;
        start = nod;
        start->prev = last;
        last->next = start;
    }
}

//insert at the ending
void CircularDoublyLinkedList::insert_end(unsigned long int x) {
    struct Node* nod;
    nod = createNode(x);
    if (start == last && start == NULL) {
        cout << "It's empty list" << endl;
        start = last = nod;
        start->next = last->next = NULL;
        start->prev = last->prev = NULL;
    }
    else {
        last->next = nod;
        nod->prev = last;
        last = nod;
        start->prev = last;
        last->next = start;
    }
}

//insert at a position
void CircularDoublyLinkedList::insert_pos(unsigned long int x, int pos) {
    struct Node* nod, * s, * ptr;
    nod = createNode(x);
    if (start == last && start == NULL) {
        if (pos == 1) {
            insert_begin(x);
        }
        else {
            cout << "Position out of range" << endl;
            count--;
            return;
        }
    }
    else {
        if (count < pos) {
            cout << "Position out of range" << endl;
            count--;
            return;
        }
        s = start;
        for (int i = 1; i <= count; i++)
        {
            ptr = s;
            s = s->next;
            if (i == pos - 1) {
                ptr->next = nod;
                nod->prev = ptr;
                nod->next = s;
                s->prev = nod;
                break;
            }
        }
    }
}

//delete at position
void CircularDoublyLinkedList::delete_pos(int pos) {
    Node* s, * ptr;
    //khi danh sách r?ng
    if (start == last && start == NULL) {
        cout << "Empty List" << endl;
    }
    //khi v? trí xóa không n?m trong danh sách
    if (count < pos) {
        cout << "Position out of range" << endl;
    }
    s = start; //gán bi?n t?m
    if (pos == 1) {
        count--;
        last->next = s->next;
        s->next->prev = last;
        start = s->next;
        free(s);
    }
    else
    {
        for (int i = 0; i < pos - 1; i++)
        {
            s = s->next;
            ptr = s->prev;
        }
        ptr->next = s->next;
        s->next->prev = ptr;
        if (pos == count) {
            last = ptr;
        }
        count--;
        free(s);
    }
}

void CircularDoublyLinkedList::update(unsigned long int x, int pos) {
    if (start == last && start == NULL) {
        cout << "List is empty!" << endl;
    }
    if (count < pos) {
        cout << "Position is out of range";
    }
    //update vào v? trí b?t d?u
    Node* temp;
    temp = start;
    if (pos == 1) {
        temp->data = x;
    }
    for (int i = 0; i < pos - 1; i++) {
        temp = temp->next;
    }
    temp->data = x;
}

void CircularDoublyLinkedList::reverse() {
    if (start == last && start == NULL) {
        cout << "List is empty!" << endl;
    }
    struct Node* p1, * p2;
    p1 = start;
    p2 = p1->next;
    p1->next = NULL;
    p1->prev = p2;
    while (p2 != start) {
        p2->prev = p2->next;
        p2->next = p1;
        p1 = p2;
        p2 = p2->prev;
    }
    last = start;
    start = p1;
    cout << "List Reversed" << endl;
}


void CircularDoublyLinkedList::display() {
    struct Node* temp;
    if (start == last && start == NULL) {
        cout << "List is empty!" << endl;
    }
    temp = start;
    for (int i = 0; i < count - 1; i++) {
        cout << temp->data << "<->";
        temp = temp->next;
    }
    cout << temp->data << endl;
}

void CircularDoublyLinkedList::swap (Node* a, Node* b )  
{ 
	unsigned long int temp = a->data;
    a->data = b->data;
    b->data = temp; 
}  
void CircularDoublyLinkedList::sort()
{
 struct Node *t, *s;
   int v, i;
   if (start == last && start == NULL) {
      cout<<"The List is empty, nothing to sort"<<endl;
      return;
   }
   s = start;
   for (i = 0;i < count;i++) {
      t= s->next;
      while (t != start) {
         if (s->data > t->data) {
            swap(s,t);
         }
         t = t->next;
      }
      s = s->next;
   }
}
int main()
{
    FILE* f = fopen("input.txt", "r");
    CircularDoublyLinkedList cdl;
    int c, n, data;
    fscanf(f, "%d", &n);
    for (int i = 1; i <= n; i++)
    {
        fscanf(f, "%d", &data);
        cdl.insert_begin(data);
    }
    cdl.display();
    fclose(f);
    while (1) 
    {
        cout << "1.Insert at Beginning" << endl;
        cout << "2.Insert at End" << endl;
        cout << "3.Insert at Position" << endl;
        cout << "4.Delete at Position" << endl;
        cout << "5.Update Node" << endl;
        cout << "6.Display List" << endl;
        cout << "7.Sort" << endl;
        cout << "8.Reverse List" << endl;
        cout << "9.Exit" << endl;
        cout << "Enter your choice : ";
        cin >> c;
        switch (c) {
        case 1:
        	cdl.display();
            cdl.insert_begin(10000);
            cdl.display();
            break;
        case 2:
        	cdl.display();
            cdl.insert_end(10001);
            cdl.display();
            break;
        case 3:
        	cdl.display();
            cdl.insert_pos(10005, 3);
            cdl.display();
            break;
        case 4:
        	cdl.display();
            cdl.delete_pos(1);
            cdl.delete_pos(2);
            cdl.delete_pos(cdl.count-1);
            cdl.display();
            break;
        case 5:
        	cdl.display();
            cdl.update(4, 1);
            cdl.display();
            break;
        case 6:
            cdl.display();
            break;
        case 7:
        	cdl.display();
        	cdl.sort();
        	cdl.display();
            break;
        case 8:
        	cdl.display();
            cdl.reverse();
            cdl.display();
            break;
        case 9:
            exit(1);
        default:
            cout << "Wrong choice" << endl;
        }
    }
    return 0;
}


