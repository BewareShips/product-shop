import React, { useState } from 'react';
import { ProductType } from '../../types/ProductType';
import styles from './ProductCard.module.css';
import FallbackImage from '../fallbackImage/FallbackImage';
import Button from '../common/button/Button';


const ProductCard: React.FC<{ product: ProductType }> = ({product}) => {
   const [quantity, setQuantity] = useState(1);
   const productImage = `/images/${product.id}.jpg`;

   const incrementQuantity = () => setQuantity(quantity + 1);
   const decrementQuantity = () => setQuantity(quantity > 1 ? quantity - 1 : 1);

   return (
      <div
         className={styles.card}
         role="region"
         aria-labelledby={`product-name-${product.id}`}
      >
         <FallbackImage
            src={productImage}
            alt={product.name}
            className={styles.image}
         />
         <h2 className={styles.name} id={`product-name-${product.id}`}>
            {product.name}
         </h2>
         <p className={styles.description}>{product.description}</p>
         <p className={styles.price}>
            Price: {product.price} euro / {product.unitType}
         </p>
         <div className={styles.quantityControl} aria-label="Quantity control">
            <Button
               className={styles.button}
               onClick={decrementQuantity}
               aria-label="Decrease quantity by one"
            >
               -
            </Button>
            <span>{quantity}</span>
            <Button
               className={styles.button}
               onClick={incrementQuantity}
               aria-label="Increase quantity by one"
            >
               +
            </Button>
         </div>
         <Button
            className={styles.addToCartButton}
            aria-label={`Add ${product.name} to basket`}
         >
            Add to basket
         </Button>
      </div>
   );
};

export default ProductCard;
