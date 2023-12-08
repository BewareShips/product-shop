import  { FC, useState } from 'react';
import plaeholderImage from '../../assets/images/placeholder.png';

interface FallbackImageProps {
   src: string;
   alt: string;
   className?: string;
}

const FallbackImage: FC<FallbackImageProps> = ({ src, alt, className }) => {
   const [imageError, setImageError] = useState(false);
   return (
      <img
         src={imageError ? plaeholderImage : src}
         alt={alt}
         className={className}
         onError={() => setImageError(true)}
      />
   );
};

export default FallbackImage;
