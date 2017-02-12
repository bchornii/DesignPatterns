namespace _03_Observer
{
    /*
    * При такой реализации поддерживается несколько издателей для одного подписчика. Передача
    * издателя в качестве параметра метода Update позволяет подписчику определить, состояние какого из
    * издателей изменилось
    */
    public abstract class Observer
    {
        public abstract void Update(Subject subject);
    }
}