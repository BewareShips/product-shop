import React, { useEffect } from 'react';
import styles from './Product.module.css';
import ProductCard from '@components/product/ProductCard';
import { useAppDispatch, useAppSelector } from '@hooks/useApp';

import { fetchProducts } from '@api/thunks';
import Button from '@components/common/button/Button';

const Product: React.FC = () => {
   const { products, categories } = useAppSelector(
      (state) => state.productCategory
   );
   const dispatch = useAppDispatch();

   useEffect(() => {
      dispatch(fetchProducts());
   }, []);

   return (
      <>
         {/* <div className={styles.container}>
            <div className={styles.filters}>
               {categories.map((category) => (
                  <Button key={category.id}>{category.name}</Button>
               ))}
            </div>
         </div> */}
         <aside className={styles.sidebar}>
        <h2>Категории</h2>
        <ul>
          {categories.map((category) => (
            <li key={category} >
              {category.name}
            </li>
          ))}
        </ul>
      </aside>
         <div className={styles.productList}>
            {products.map((product) => (
               <ProductCard key={product.id} product={product} />
            ))}
         </div>
      </>
   );
};

export default Product;
