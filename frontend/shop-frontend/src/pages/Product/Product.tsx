import React from 'react';
import { useParams } from 'react-router-dom';

const Product: React.FC = () => {
  const { id } = useParams<{ id: string }>();

  return (
    <div>
      <h1>Product Page for Product ID: {id}</h1>
    </div>
  );
};

export default Product;