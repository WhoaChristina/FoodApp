import './DishCard.css'
const DishCard = ({dish}) =>
{
    return(<>
    <div className="card">
        <h3 className="dish-second-head">{dish.name}</h3>
        <p className="dish-text">{dish.ingredients}</p>
    </div>
    </>)
}
export default DishCard;