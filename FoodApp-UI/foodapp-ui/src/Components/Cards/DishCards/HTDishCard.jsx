import './DishCard.css'
const HTDishCard = ({dish}) =>
{
    return(<>
    <div className="card">
        <h3 className="dish-second-head">{dish.name}, {dish.rating} / 10</h3>
        <p className="dish-text">{dish.ingredients}</p>
    </div>
    </>)
}
export default HTDishCard;