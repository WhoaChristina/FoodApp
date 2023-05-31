import HTCDishCard from "../Cards/DishCards/HTCDishCard"
import DishCard from "../Cards/DishCards/DishCard"
import HTDishCard from "../Cards/DishCards/HTDishCard"
const DishesComponent = ({list, name}) =>
{
    let dishList = list.map(dish =>
        {
            if(dish.haveTried === true)
            {
                if (dish.comment == null)
                {
                    return(<>
                        <HTDishCard dish ={dish} />
                    </>)
                }
                else
                {
                    return(<>
                        <HTCDishCard dish = {dish} />
                    </>)
                }
            }
            else
            {
                return(<>
                    <DishCard dish = {dish} />
                </>)
            }
        })
        return(<>
        <h1 className="dish-head">{name}</h1>
        <div className="wrapper">
            {dishList}
        </div>
        </>)
}
export default DishesComponent;